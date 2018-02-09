﻿/*
 * Created by: Octavio Loyola González (octavioloyola@gmail.com)
 * Created: 
 * Comments by: 
 */

namespace PatternRecognition.FingerprintRecognition.Core.ImageProcessingTools.ConvolutionFilters
{
    public class GaussianBlur : ConvolutionFilter
    {
        public GaussianBlur()
        {
            pixels = new int[5, 5] {
                                   {0,1,2,1,0},
                                   {1,2,3,2,1},
                                   {2,3,4,3,2},
                                   {1,2,3,2,1},
                                   {0,1,2,1,0}
                               };
        }
        /// <summary>
        ///     Gets the value 5 which is the height of the filter.
        /// </summary>
        public override int Height => 5;

        /// <summary>
        ///     Gets the value 5 which is the width of the filter.
        /// </summary>
        public override int Width => 5;

        /// <summary>
        ///     Gets the value 40 which is the factor to divide the value before assigning to the pixel.
        /// </summary>
        public override int Factor => 40;
    }
}
