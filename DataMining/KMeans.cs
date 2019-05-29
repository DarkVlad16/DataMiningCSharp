namespace DataMining
{
    public class KMeans
    {
        public int K { get; }
        public double[][] Centroids { get; set; }
        public int Clusters { get; }

        public int[] Compute(double[][] data, double threshold)
        {
            int k = K;
            int rows = data.Length;
            int cols = data[0].Length;
            
            // pick K unique random indexes in the range 0..n-1
            //int[] idx = Accord.Statistics.Tools.Random(rows, k);

            // assign centroids from data set
            //Centroids = data.Submatrix(idx);
            
            // initial variables
            int[] count = new int [k];
            int[] labels = new int [rows];
            double[][] newCentroids;


            do // main loop
            {

                // Reset the centroids and the
                //  cluster member counters'
                newCentroids = new double [k][];
                for (int i = 0; i < k; i++)
                {
                    newCentroids[i] = new double [cols];
                    count[i] = 0;
                }


                // First we will accumulate the data points
                // into their nearest clusters, storing this
                // information into the newClusters variable.

                // For each point in the data set,
                for (int i = 0; i < data.Length; i++)
                {
                    // Get the point
                    double[] point = data[i];

                    // Compute the nearest cluster centroid
                    int c = 0; //labels[i] = Nearest(data[i]);

                    // Increase the cluster's sample counter
                    count[c]++;

                    // Accumulate in the corresponding centroid
                    double[] centroid = newCentroids[c];
                    for (int j = 0; j < centroid.Length; j++)
                    centroid[j] += point[j];
                }

                // Next we will compute each cluster's new centroid
                //  by dividing the accumulated sums by the number of
                //  samples in each cluster, thus averaging its members.
                for (int i = 0; i < k; i++)
                {
                    double[] mean = newCentroids[i];
                    double clusterCount = count[i];

                    for (int j = 0; j < cols; j++)
                    mean[j] /= clusterCount;
                }


                // The algorithm stops when there is no further change in
                //  the centroids (difference is less than the threshold).
                //if (Centroids.IsEqual(newCentroids, threshold))
                    //break;

                // go to next generation
                Centroids = newCentroids;

            } while (true);


            // Compute cluster information (optional)
            //for (int i = 0; i < k; i++)
            //{
            //    // Extract the data for the current cluster
            //    double[][] sub = data.Submatrix(labels.Find(x => x == i));

            //    // Compute the current cluster variance
            //    covariances[i] = Statistics.Tools.Covariance(sub, centroids[i]);

            //    // Compute the proportion of samples in the cluster
            //    proportions[i] = (double) sub.Length / data.Length;
            //}


            // Return the classification result
            return labels;
        }
    }
}