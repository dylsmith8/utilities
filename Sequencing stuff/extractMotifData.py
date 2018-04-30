import os
from Bio import SeqIO
from Bio.Seq import Seq

# location of fasta files we want to parse (output will be put there)
os.chdir(r'C:\Users\User\Documents\VS Code Projects\Extracting Motif Data - Python script\fasta files')

# sequences we want
seq_id = ':2|PDBID|CHAIN|SEQUENCE'
seq_id_alt = ':B|PDBID|CHAIN|SEQUENCE'

# get the list of fasta files
txt_list=os.listdir(r'C:\Users\User\Documents\VS Code Projects\Extracting Motif Data - Python script\fasta files')

# iterate through each file &  extract each sequence
result=open('output.txt','w')
for item in txt_list:
   with open (item,'rU') as file:
     fileWithoutExt = os.path.splitext(file.name)[0]
     toCompare = fileWithoutExt.upper() + seq_id
     toCompareAlt = fileWithoutExt.upper() + seq_id_alt
     for records in SeqIO.parse(file,'fasta'):        
          if (records.id == toCompare or records.id == toCompareAlt):
               result.write('>' + fileWithoutExt.upper() + '\n')
               result.write(str(records.seq) + '\n')
               result.write('\n')      
          else:
               continue
result.close()
