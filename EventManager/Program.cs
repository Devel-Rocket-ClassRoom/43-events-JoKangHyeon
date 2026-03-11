SoundSystem soundSystem = new SoundSystem();
ScoreSystem scoreSystem = new ScoreSystem();
AchievementSystem achievementSystem = new AchievementSystem();

EventManager.TriggerEvent("ScoreChanged", 100);
EventManager.TriggerEvent("Achievement", "첫 번째 적 처치");
EventManager.TriggerEvent("GameOver");