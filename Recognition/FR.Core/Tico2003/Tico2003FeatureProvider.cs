﻿/*
 * Created by: Miguel Angel Medina Pérez (miguel.medina.perez@gmail.com)
 * Created: 
 * Comments by: Miguel Angel Medina Pérez (miguel.medina.perez@gmail.com)
 */

using System;
using PatternRecognition.FingerprintRecognition.Core.Ratha1995;

namespace PatternRecognition.FingerprintRecognition.Core.Tico2003
{
    public class Tico2003FeatureProvider 
    {
        private readonly Tico2003FeatureExtractor _featureExtractor = new Tico2003FeatureExtractor();

        public OrientationImageProvider OrImgProvider { get; set; }

        public Tico2003Features Extract(byte[] image)
        {
            var mtiae = MinutiaeExtractor.ExtractFeatures(ImageProvider.GetResource(image));
            var dirImg = OrImgProvider.Extract(image);

            return _featureExtractor.ExtractFeatures(mtiae, dirImg);
        }
    }
}