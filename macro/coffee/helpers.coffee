



days = []
registerDay = (day, start) ->
	days.push new Day(day, start)

categories = []
registerCategory = (category, localDays) ->
	localDays = localDays.split ","
	dayObjects = []
	for day in localDays
		for dayObject in days when dayObject.name == day.replace(/^\s+/, "").replace(/\s+$/, "")
			dayObjects.push dayObject

	categories.push new Category(category, dayObjects) if dayObjects.length

teams = []
registerTeam = (team, category) ->
	for catObject in categories when catObject.name == category
		teams.push(new Team team, catObject)


register = (type, param1, param2) ->
	switch type
		when "day" then registerDay(param1, param2)
		when "category" then registerCategory(param1, param2)
		when "team" then registerTeam(param1, param2)


lpad = (value, padding) ->
	value = '0' + value while ('' + value).length < padding
	value


`function shuffle(o){ //v1.0
    for(var j, x, i = o.length; i; j = Math.floor(Math.random() * i), x = o[--i], o[i] = o[j], o[j] = x);
    return o;
};
`


if typeof(ActiveXObject) != "undefined"
	myMsgBox = new ActiveXObject("wscript.shell")
	alert = (msg) ->
		myMsgBox.Popup msg