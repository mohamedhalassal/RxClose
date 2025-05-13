from flask import Flask, request, jsonify
from src.helper import download_hugginface_embedding
from langchain_pinecone import PineconeVectorStore
import google.generativeai as genai
from langchain_google_genai import ChatGoogleGenerativeAI
from langchain.chains import create_retrieval_chain
from langchain.chains.combine_documents import create_stuff_documents_chain
from langchain_core.prompts import ChatPromptTemplate
from src.prompt import system_prompt
import os


# Set the environment variables for Pinecone and Gemini API keys
os.environ["PINECONE_API_KEY"] = "pcsk_29YpbD_SHWVCkHpPQMnuto42uEqyduYCM2D3SeUNV5guDWeMNrj71rZMASqzNr26EvisMJ"
os.environ["GEMINI_API_KEY"] = "AIzaSyDD-JCNt-B99ZgKHGIc0ET-z5D8tCt3t6E"

PINECONE_API_KEY = os.getenv("PINECONE_API_KEY")
GEMINI_API_KEY = os.getenv("GEMINI_API_KEY")

embeddings = download_hugginface_embedding()

# Load the existing index from Pinecone
index_name = "medicalbot"
docsearch = PineconeVectorStore.from_existing_index(index_name=index_name, embedding=embeddings)
retriever = docsearch.as_retriever(search_type="similarity", search_kwargs={"k": 10})

# Initialize the LLM
llm = ChatGoogleGenerativeAI(model="gemini-2.0-flash", google_api_key=GEMINI_API_KEY)
system_prompt = (
    "You are a knowledgeable assistant tasked with answering questions based on the full provided context. "
    "Analyze all the information before generating a response. "
    "Do not rely on individual sentences in isolation—synthesize information across the entire context. "
    "If the answer cannot be determined from the context, respond with 'I don't know.' "
    "Your answer should be clear, accurate.\n\n{context}"
)

prompt = ChatPromptTemplate.from_messages([("system", system_prompt), ("human", "{input}")])
question_answer_chain = create_stuff_documents_chain(llm=llm, prompt=prompt)
rag_chain = create_retrieval_chain(retriever, question_answer_chain)

# Initialize Flask app
app = Flask(__name__)


@app.route('/chatbot', methods=['POST'])
def ask():
    try:
        # Get the user's question from the request
        user_input = request.json.get("question")
        
        if not user_input:
            return jsonify({"error": "No question provided"}), 400
        
        # Query the retrieval augmented generation chain
        response = rag_chain.invoke({"input": user_input})
        
        # Get the answer from the response
        answer = response["answer"]
        
        # Return the answer as a JSON response
        return jsonify({"answer": answer})
    
    except Exception as e:
        return jsonify({"error": str(e)}), 500

if __name__ == '__main__':
   app.run(debug=True, use_reloader=False)
