using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab
{
    class MultiLevelParking
    {
        int pictureWidth;
        int pictureHeight;

        List<Parking<ITransport>> parkingStages;
        private const int countPlaces = 20;
        
        public MultiLevelParking(int countStages, int pw, int ph)
        {
            pictureWidth = pw;
            pictureHeight = ph;

            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                WriteToFile("CountLeveles:"+ parkingStages.Count + Environment.NewLine, sw);
                foreach (var level in parkingStages)
                {
                    WriteToFile("Level"+ Environment.NewLine, sw);
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var tractor = level[i];
                        if (tractor != null)
                        {
                            if (tractor.GetType().Name == "Tractor")
                            {
                                WriteToFile(i + ":Tractor:", sw);
                            }
                            if (tractor.GetType().Name == "ExcavatorTractor")
                            {
                                WriteToFile(i + ":ExcavatorTractor:", sw);
                            }
                            WriteToFile(tractor + Environment.NewLine, sw);
                        }
                    }
                }
            }
            return true;
        }

        private void WriteToFile(string text, StreamWriter sw)
        {
            sw.Write(text);
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            int counter = -1;
            ITransport tractor = null;

            using (StreamReader fr = new StreamReader(filename))
            {
                String str = fr.ReadLine();
				
		if (str.Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(str.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
				
                while (!fr.EndOfStream)
                {
                    str = fr.ReadLine();
		
                    if (str == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                    }
                    else if (str.Split(':')[1] == "Tractor")
                    {
                        tractor = new Tractor(str.Split(':')[2]);
                        parkingStages[counter][Convert.ToInt32(str.Split(':')[0])] = tractor;
                    }
                    else if (str.Split(':')[1] == "ExcavatorTractor")
                    {
                        tractor = new ExcavatorTractor(str.Split(':')[2]);
                        parkingStages[counter][Convert.ToInt32(str.Split(':')[0])] = tractor;
                    }
                }
            }
            
            return true;
        }

        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
    }
}
