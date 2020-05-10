using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheCaregiver.Classes
{
    public enum GardenGrowthStages
    {
        Nothing = 1,
        Sewn = 2,
        Growing = 3,
        ReadyToHarvest = 4
    }

    public class GardenPlot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public GardenGrowthStages GrowthStage { get; set; }
        public int GrowTicker { get; set; }

        public GardenPlot()
        {
            GrowthStage = GardenGrowthStages.Nothing;
        }
        public Bitmap GetGardenTileToDraw()
        {
            Bitmap tile = new Bitmap(TheCaregiver.Tiles.garden);

            if (GrowthStage == GardenGrowthStages.Growing)
            {
                tile = new Bitmap(TheCaregiver.Tiles.gardengrow);
            }
            else if (GrowthStage == GardenGrowthStages.ReadyToHarvest)
            {
                tile = new Bitmap(TheCaregiver.Tiles.gardenready);
            }
            else
            {
                tile = new Bitmap(TheCaregiver.Tiles.garden);
            }

            return tile;
        }
    }
}
