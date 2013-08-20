class ScheduleMaker
	constructor: () ->
		@buildSchedule = buildSchedule;
		@registerDay = registerDay;
		@registerCategory = registerCategory;
		@registerTeam = registerTeam;
		@register = register;

description = new ScheduleMaker