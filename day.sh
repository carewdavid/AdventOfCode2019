#! /bin/bash

NAME="Day$1"
FILE="$NAME.cs"
touch "$FILE"
echo -e "namespace AOC\n{" >> $FILE
echo -e "\tclass $NAME\n\t{" >> $FILE
echo -e "\t\tstatic void Solve(string[] args)\n\t\t{" >> $FILE
echo -e "\t\t}\n\t}\n}" >> $FILE

sed -i "s/\/\/<++>/$NAME.Solve();\n\/\/<++>/" AOC.cs
