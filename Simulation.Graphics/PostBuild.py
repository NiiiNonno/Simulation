import sys
import os
import shutil
import subprocess

def snake_to_pascal(s):
    return '.'.join(word.capitalize() for word in s.split('_'))

config = sys.argv[1]
dest = sys.argv[2]

if config == "Debug":
    subprocess.run(["cargo", "build", "--lib"])
    source = "target/debug"
elif config == "Release":
    subprocess.run(["cargo", "build", "--lib", "--release"])
    source = "target/release"
else:
    raise ValueError

for file_src in os.listdir(source):
    if file_src.endswith(".dll"):
        file_dst = snake_to_pascal(os.path.splitext(file_src)[0]) + ".rs.dll"
        shutil.copy2(os.path.join(source, file_src), os.path.join(dest, file_dst))
    elif file_src.endswith(".pdb"):
        file_dst = snake_to_pascal(os.path.splitext(file_src)[0]) + ".rs.pdb"
        shutil.copy2(os.path.join(source, file_src), os.path.join(dest, file_dst))
