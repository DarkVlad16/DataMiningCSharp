using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace DataMining {
    class KMeans {
        public class Coords {
            public Coords(int x, int y) {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }

            public override bool Equals(object obj) => obj is Coords coords && X == coords.X && Y == coords.Y;
        }

        public class Center {
            public Center() {
                Rels = new Collection<Coords>();
            }

            public Collection<Coords> Rels { get; set; }
            public Color Color { get; set; }
        }

        public KMeans(Bitmap bitmap) {
            this.bitmap = bitmap;
            Centers = new Dictionary<Coords, Center>();
        }

        public readonly Bitmap bitmap;
        public bool IsFindedNewCenters { get; set; }
        public Bitmap ClusterBitmap { get; private set;}
        public Dictionary<Coords, Center> Centers { get; private set; }

        public void AddCenter(Point point) {
            Centers.Add(new Coords(point.X, point.Y), new Center { Color = bitmap.GetPixel(point.X, point.Y) });
        }

        public void FindNewCenters(int steps) {
            for(var step = 0; step < steps; step++) {
                var centers = Centers.Keys.ToArray();
                for(var x = 0; x < bitmap.Width; x++) {
                    for(var y = 0; y < bitmap.Height; y++) {
                        var pixel = bitmap.GetPixel(x, y);
                        var lengths = new double[centers.Length];
                        for(var i = 0; i < centers.Length; i++) {
                            lengths[i] = Math.Sqrt(Math.Pow(pixel.R - Centers[centers[i]].Color.R, 2) + Math.Pow(pixel.G - Centers[centers[i]].Color.G, 2) + Math.Pow(pixel.B - Centers[centers[i]].Color.B, 2));
                        }
                        Centers[centers[Array.IndexOf(lengths, lengths.Min())]].Rels.Add(new Coords(x, y));
                    }
                }
                if(step == steps -1) {
                    continue;
                }
                var newCenters = new Dictionary<Coords, Center>();

                foreach(var center in Centers) {
                    var xs = new int[center.Value.Rels.Count];
                    var ys = new int[center.Value.Rels.Count];
                    for(var i = 0; i < center.Value.Rels.Count; i++) {
                        xs[i] = center.Value.Rels[i].X;
                        ys[i] = center.Value.Rels[i].Y;
                    }
                    var newCenter = center.Value.Rels.Any() ? new Coords(xs.Sum() / center.Value.Rels.Count, ys.Sum() / center.Value.Rels.Count) : center.Key;
                    newCenters.Add(newCenter, new Center { Color = bitmap.GetPixel(newCenter.X, newCenter.Y)});
                }
                Centers = newCenters;
            }

            IsFindedNewCenters = true;
        }

        public void CreateClusterBitmap()
        {
            if (!IsFindedNewCenters)
                return;

            ClusterBitmap = new Bitmap(bitmap);
            foreach (var center in Centers)
                foreach (var rel in center.Value.Rels)
                    ClusterBitmap.SetPixel(rel.X, rel.Y, center.Value.Color);
        }
        
    }
}