
# Classes
class Team
	name: ""
	category: undefined

	constructor: (@name, @category) ->
		@playedWith= []
		@category.register this

	canPlayWith: (team) =>
		return false if team.category != @category
		return false if contains(@playedWith, team)
		return false if team == this
		return true
	isDone: () =>
		return @playedWith.length == (@category.teams.length - 1)


class Category
	constructor: (@name, @days) ->
		@teams = []
		for day in @days
			day.register this
	register: (team) ->
		@teams.push team

class Day
	constructor: (@name, @start) ->
		@categories = []
	register: (category) ->
		@categories.push category


class Clock
	constructor: (@hour, @minute) ->

	forward: (step) ->
		@hour++ if ((@minute + step) % 60) < @minute
		@minute = (@minute + step) % 60
		return this

	backward: (step) ->
		@minute -= step
		if(@minute < 0)
			@minute = 60 + @minute
			@hour--
		return this

	toString: () ->
		return lpad(@hour, 2) + ":" + lpad(@minute, 2)