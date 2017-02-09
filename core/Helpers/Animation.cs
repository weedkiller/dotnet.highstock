﻿using DotNet.HighStock.Attributes;
using DotNet.HighStock.Enums;

namespace DotNet.HighStock.Helpers
{
    public class Animation
    {
        [Name("animation")]
        public bool? EnableAnimation { get; private set; }

        [Name("animation")]
        public AnimationConfig AnimationConfig { get; private set; }

        public Animation(bool animation) { EnableAnimation = animation; }

        public Animation(AnimationConfig animation) { AnimationConfig = animation; }
    }

    public class AnimationConfig
    {
        /// <summary>
        /// The duration of the animation in milliseconds.
        /// </summary>
        /// <see cref="http://api.highcharts.com/highstock#chart--animation"/>
        public int? Duration { get; set; }

        /// <summary>
        /// When using jQuery as the general framework, the easing can be set to linear or swing. 
        /// More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. 
        /// See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// </summary>
        /// <see cref="http://api.highcharts.com/highstock#chart--animation"/>
        public EasingTypes? Easing { get; set; }
    }
}