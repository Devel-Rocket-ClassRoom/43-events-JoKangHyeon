ChatRoom chatRoom = new ChatRoom();
ChatLogger chatLogger = new ChatLogger(chatRoom);
NotificationService notificationService = new NotificationService(chatRoom);

chatRoom.SendMessage("철수", "안녕하세요");
chatRoom.SendMessage("영희", "긴급 회의가 있습니다");
chatRoom.SendMessage("민수", "점심 뭐 먹을까요?");
