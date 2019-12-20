using Marvel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.DAL
{
    public class DataLayer
    {
            private Character movieObject(int i, string n, string t)
            {
                var m = new Character();
                m.ID = i;
                m.name = n;
                m.title = t;

                return m;
            }

            //Manually adding data into the list
            public List<Character> LoadInformation()
            {
                var marvList = new List<Character>();
                var m = new Character();

                m = movieObject(1, "Steve Rogers", "Captain America");
                marvList.Add(m);
                m = movieObject(2, "Tony Stark", "Iron Man");
                marvList.Add(m);
                m = movieObject(3, "Thor", "God Of Thunder");
                marvList.Add(m);
                m = movieObject(4, "Agent Romanof", "Black widow");
                marvList.Add(m);
                m = movieObject(5, "Steven Strange", "Doctor Strange");
                marvList.Add(m);
                m = movieObject(6, "Peter Parker", "Spider man");
                marvList.Add(m);
                m = movieObject(7, "Bucky Barnes", "Winter Soldier");
                marvList.Add(m);
                m = movieObject(8, "Thanos", "The Mad Titan");
                marvList.Add(m);
                m = movieObject(9, "Bruce Banner", "Hulk");
                marvList.Add(m);
                m = movieObject(10, "Hela", "Godess of Death");
                marvList.Add(m);
                m = movieObject(11, "Peter Parker", "Spider man");
                marvList.Add(m);
                m = movieObject(12, "Eddy Brock", "Venom");
                marvList.Add(m);

                return marvList;
            }
        }
}
