import os
import re

def replace_in_file(file_path, old, new):
    with open(file_path, 'r+', encoding='utf-8') as f:
        content = f.read()
        content = content.replace(old, new)
        f.seek(0)
        f.write(content)
        f.truncate()

def process_dir(dir_path, old, new):
    for root, _, files in os.walk(dir_path):
        for file in files:
            if file.endswith('.cs'):
                replace_in_file(os.path.join(root, file), old, new)

replace_data = [
    #("dictionary", "technical"),
    #("Dictionary", "Technical")
        ]

for i in replace_data:
    process_dir(os.getcwd(), i[0], i[1])
