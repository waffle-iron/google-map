﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Artem.Google.UI {

    /// <summary>
    /// Options for the rendering of the rotate control.
    /// </summary>
    public class RotateControlOptions : IScriptDataConverter {

        #region Static Methods

        /// <summary>
        /// Retrieves an instance from script data.
        /// </summary>
        /// <param name="scriptObject">The script object.</param>
        /// <returns></returns>
        public static RotateControlOptions FromScriptData(object scriptObject) {

            var data = scriptObject as IDictionary<string, object>;
            if (data != null) {
                object value;
                var options = new RotateControlOptions();
                if (data.TryGetValue("position", out value)) options.Position = (ControlPosition)value;
                return options;
            }
            return null;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Position id. Used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        /// <value>The position.</value>
        public ControlPosition Position { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the instance as a script data.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> ToScriptData() {
            return new Dictionary<string, object> { { "position", this.Position } };
        }
        #endregion
    }
}
