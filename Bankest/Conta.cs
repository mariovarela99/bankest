using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bankest
{
    public class Conta
    {
        double saldo = 0.0;
        string owner = "";
        string createdAt = "";
        string updatedAt = "";
        private string path = @"C:\Program Files";

        public string Create(string firstName, string lastName, string bi, string dateNasc, string numberContribuinte, string Morada, string Trabalho, string Tel, string Email)
        {
            DirectoryInfo Dir = new DirectoryInfo(path);
            Dir.CreateSubdirectory("Bankest");
            FileInfo AccountsFile =  new FileInfo(String.Format("{0}/Bankest/Accounts.txt", path));
            File.AppendAllText(AccountsFile.FullName, String.Format("\n {0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7} \t {8}", firstName, lastName, bi, dateNasc,numberContribuinte, Morada, Trabalho,  Tel, Email));

            return "Created";
        }
    }
}
