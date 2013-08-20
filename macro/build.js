var coffee = require("coffee-script");
var UglifyJS = require("uglify-js");
var fs = require("fs");
var _ = require("underscore");
var vm = require("vm");


if(!fs.existsSync("build"))
	fs.mkdirSync("build");


// Concatenate files
var coffeeCode = "";
var jsCode = "";


// Compile Coffee
fs.readdir('./coffee/',function(err,files){
    if(err) throw err;
    files.forEach(function(file){
        coffeeCode += "\n" + fs.readFileSync("coffee/" + file);
    });


    jsCode = coffee.compile(coffeeCode, {bare: true});

    // Compile JS
	fs.readdir('./js/', function(err,jsFiles){
		jsFiles.forEach(function(file){
		    jsCode += "\n" + fs.readFileSync("js/" + file);
		});

		uglified = UglifyJS.minify(jsCode, {fromString: true});
		jsCode = uglified.code;
		
		// Compile template
		var template = _.template(fs.readFileSync("templates/ScheduleMaker.template", "utf8"));

		var context = {};
		vm.runInNewContext(jsCode, context);
		
		var maker = new context.ScheduleMaker();
		
		var wscFile = template({
			code: jsCode,
			methods: _.keys(maker)
		});

		fs.writeFile("build/ScheduleMaker.wsc", wscFile);
	});
 });


// var coffeeCode = UglifyJS.minify(["coffee/*.js"]);

// console.log(coffeeCode.code);