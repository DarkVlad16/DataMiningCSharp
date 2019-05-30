using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace DataMining {
    class KMeans {
        class Coords {
            public Coords(int x, int y) {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }
        }

        class Center {
            public Center() {
                Coords = new Collection<Coords>();
            }

            public Collection<Coords> Coords { get; }
            public Color Color { get; set; }
        }

        public KMeans(Bitmap bitmap) {
            this.bitmap = bitmap;
        }

        readonly Bitmap bitmap;
        readonly Center[] centers;

        public void FindNewCenters(int steps) {
            for(var step = 0; step < steps; step++) {
                var centers = new dynamic[0];
                for(var x = 0; x < bitmap.Width; x++) {
                    for(var y = 0; y < bitmap.Height; y++) {
                        var pixel = bitmap.GetPixel(x, y);
                        var lengths = new double[centers.Length];
                        for(var i = 0; i < centers.Length; i++) {
                            lengths[i] = Math.Sqrt(Math.Pow(pixel.R - this.centers[i].Color.R, 2) + Math.Pow(pixel.G - this.centers[i].Color.G, 2) + Math.Pow(pixel.B - this.centers[i].Color.B, 2));
                        }
                        this.centers[Array.IndexOf(lengths, lengths.Min())].Coords.Add(new Coords(x, y));
                    }
                }
                if(step == steps -1) {
                    continue;
                }
                var newCenters = new { };
                foreach(var center in this.centers) {
                    var xs = new int[center.Coords.Count];
                    var ys = new int[center.Coords.Count];
                    for(var i = 0; i < center.Coords.Count; i++) {
                        xs[i] = center.Coords[i].X;
                        ys[i] = center.Coords[i].Y;
                    }
                    //var newCenter = center.Coords.Any() ? new Coords(xs.Sum() / center.Coords.Count, ys.Sum() / center.Coords.Count) : center;
                }
            }
        }
    }
}