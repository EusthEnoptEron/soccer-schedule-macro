buildSchedule = () ->
	schedules = []
	step = 15

	# Calculation
	for day in days
		schedule = []
		availableCategories = (category for category in categories when contains(category.days, day))
		availableTeams = (team for team in teams when contains(availableCategories, team.category) && !team.isDone())
		pendingTeams = []

		time = day.start.split ":"
		hour = parseInt time[0]
		minute = parseInt time[1]

		clock = new Clock hour, minute


		while availableTeams.length || pendingTeams.length
			shuffle availableTeams
			team = availableTeams.shift()
			# look for opponent
			validEnemy = undefined
			for enemyTeam in availableTeams
				if team.canPlayWith(enemyTeam)
					validEnemy = enemyTeam
					break

			# add bacl waiting players to the list
			while waitingTeam = pendingTeams.shift()
				availableTeams.push waitingTeam


			if validEnemy
				# add to schedule
				schedule.push
					startTime: clock.toString()
					endTime: clock.forward(step).toString()
					team1: team.name
					team2: validEnemy.name
					category: team.category.name

				# return clock
				clock.backward(step)

				index = getIndex availableTeams, validEnemy

				availableTeams.splice(index, 1)

				validEnemy.playedWith.push team
				team.playedWith.push validEnemy

				pendingTeams.push team unless team.isDone()
				pendingTeams.push validEnemy unless validEnemy.isDone()
				# if team.isDone()
				# 	console.log team.name + " of " + team.category.name + " with " + team.playedWith.length
				# if validEnemy.isDone()
				# 	console.log validEnemy.name + " of " + validEnemy.category.name + " with " + validEnemy.playedWith.length
				clock.forward step
			else				
				# append at end
				availableTeams.push team

			

		schedules.push { name: day.name, schedule: schedule }
	return schedules

