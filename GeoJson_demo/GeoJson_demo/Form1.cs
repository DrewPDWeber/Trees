using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoJSON;
using GeoJSON.Net.Geometry;
using Newtonsoft.Json;
using GeoJSON.Net.Feature;
namespace GeoJson_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Tree
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Species { get; set; }
            public GeoTypeInfo GeoType { get; set; }
        }
        public class GeoTypeInfo
        {
            public int Type { get; set; }
            public FeatureCollection Values { get; set; }
        }


   
        private void button1_Click(object sender, EventArgs e)
        {
            var polygon = new Polygon(new List<LineString>
        {
            new LineString(new List<IPosition>
            {
                new Position(20.236237,39.4116761),
                new Position(20.2363602,39.4115249),
                new Position(20.2365152,39.4110652),
                new Position(20.2364942,39.4104468),
                new Position(20.236237,39.4116761),
            })
        });
        var featureCollection = new FeatureCollection(new List<Feature>()
        {
                new Feature(polygon)
        });

         var tree = new Tree()
         {
                Id = 1,
                Name = "My first Tree",
                Species = "Potato",
                GeoType = new GeoTypeInfo()
                {
                    Type = 2,
                    Values = featureCollection
                }
          };

          var theTree = JsonConvert.SerializeObject(tree);
            idLable.Text = JsonConvert.SerializeObject(tree.Id);
            nameLabel.Text = JsonConvert.SerializeObject(tree.Name);
            speciesLabel.Text = JsonConvert.SerializeObject(tree.Species);
            geoinfoTextbox.Text = JsonConvert.SerializeObject(tree);


        }
    }
}
