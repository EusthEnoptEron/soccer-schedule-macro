function contains(arr, item) {
	return getIndex(arr, item) >= 0;
}
function getIndex(arr, item) {
	return indexOf.call(arr, item)
}
function indexOf (searchElement /*, fromIndex */ ) {
  "use strict";

  if (this == null) {
    throw new TypeError();
  }

  var t = Object(this);
  var len = t.length >>> 0;

  if (len === 0) {
    return -1;
  }

  var n = 0;

  if (arguments.length > 0) {
    n = Number(arguments[1]);

    if (n != n) { // shortcut for verifying if it's NaN
      n = 0;
    } else if (n != 0 && n != Infinity && n != -Infinity) {
       n = (n > 0 || -1) * Math.floor(Math.abs(n));
    }
  }

  if (n >= len) {
    return -1;
  }

  var k = n >= 0 ? n : Math.max(len - Math.abs(n), 0);

  for (; k < len; k++) {
    if (k in t && t[k] === searchElement) {
      return k;
    }
  }
  return -1;
}


JSON = {
  parse: function (sJSON) { return eval("(" + sJSON + ")"); },
  stringify: function (vContent) {
    if (vContent instanceof Object) {
      var sOutput = "";
      if (vContent.constructor === Array) {
        for (var nId = 0; nId < vContent.length; sOutput += this.stringify(vContent[nId]) + ",", nId++);
        return "[" + sOutput.substr(0, sOutput.length - 1) + "]";
      }
      if (vContent.toString !== Object.prototype.toString) { return "\"" + vContent.toString().replace(/"/g, "\\$&") + "\""; }
      for (var sProp in vContent) { sOutput += "\"" + sProp.replace(/"/g, "\\$&") + "\":" + this.stringify(vContent[sProp]) + ","; }
      return "{" + sOutput.substr(0, sOutput.length - 1) + "}";
    }
    return typeof vContent === "string" ? "\"" + vContent.replace(/"/g, "\\$&") + "\"" : String(vContent);
  }
};