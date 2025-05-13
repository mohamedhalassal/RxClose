from langchain_community.document_loaders import PyPDFLoader, DirectoryLoader
from langchain.text_splitter import RecursiveCharacterTextSplitter
from langchain.embeddings import HuggingFaceEmbeddings



# Extract data from pdf files
def load_pdf_file(data):
     loader = DirectoryLoader(path=data,
                              glob="*.pdf",
                              loader_cls=PyPDFLoader)
     
     document = loader.load()
     return document



# Split the data into chunks
def text_split(extracted_data):
     text_splitter = RecursiveCharacterTextSplitter(chunk_size=500, chunk_overlap=20)
     text_chunks = text_splitter.split_documents(extracted_data)
     return text_chunks



# Download the embedding from HuggingFace
def download_hugginface_embedding():
     embeddings = HuggingFaceEmbeddings(model_name="sentence-transformers/all-MiniLM-L6-v2")
     return embeddings