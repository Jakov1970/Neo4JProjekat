using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;
using Neo4jClient.Cypher;
using Neo4JProjekat.QueryEntities;

namespace Neo4JProjekat
{
    public partial class Form1 : Form
    {
        private GraphClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "baze2020");

            try
            {
                client.Connect();
                Console.WriteLine("Konektovano na bazu");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Kompanija) return n", new Dictionary<string, object>(), CypherResultMode.Set);

            List<Kompanija> kompanije = ((IRawGraphClient)client).ExecuteGetCypherResults<Kompanija>(query).ToList();
        
            foreach (Kompanija k in kompanije)
            {
                MessageBox.Show(k.ime);
            }
        
        
        }


    }
}
