using System;

Console.WriteLine();
Console.WriteLine("## 1. 대리자 복습");

void SayHello()
{
    Console.WriteLine("안녕하세요!");
}

void SayGoodbye()
{
    Console.WriteLine("안녕히 가세요!");
}

Notify notify = SayHello;
notify += SayGoodbye;
notify();



Console.WriteLine();
Console.WriteLine("## 2. 기본 이벤트 선언");

void HandleClick()
{
    Console.WriteLine("버튼이 클릭되었습니다!");
}

void HandleClickAgain()
{
    Console.WriteLine("클릭 처리 완료");
}

Button button = new Button();
button.Click += HandleClick;
button.Click += HandleClickAgain;

button.OnClick();



Console.WriteLine();
Console.WriteLine("3. 이벤트 구독");

Player player = new Player();
HealthBar healthBar = new HealthBar();
SoundManager soundManager = new SoundManager();

player.DamageTanken += healthBar.OnPlayerDamaged;
player.DamageTanken += soundManager.OnPlayerDamaged;

player.TakeDamage(30);



Console.WriteLine();
Console.WriteLine("4. 이벤트 해제");

Timer timer = new Timer();
Logger logger = new Logger();

Console.WriteLine("=== 구독 상태 ===");
timer.Tick += logger.OnTick;
timer.Start();

Console.WriteLine();
Console.WriteLine("=== 구독 해제 후 ===");
timer.Tick -= logger.OnTick;
timer.Start();



Console.WriteLine();
Console.WriteLine("5. 람다식 이벤트 핸들러");

Sensor sensor = new Sensor();
sensor.Alert += message => Console.WriteLine($"[경보] {message}");
sensor.Alert += message => Console.WriteLine($"[로그] {DateTime.Now}: {message}");

sensor.Detect("움직임 감지됨");
sensor.Detect("온도 상승");



Console.WriteLine();
Console.WriteLine("6. Action 대리자 활용");

GameCharacter character = new GameCharacter();
character.OnAttack += (amount, target) => Console.WriteLine($"{target}에게 {amount} 데미지!");
character.OnDamaged += (health) => Console.WriteLine($"남은 체력: {health}");
character.OnDeath += () => Console.WriteLine("캐릭터가 사망했습니다");

character.Attack(50, "슬라임");
character.TakeDamage(30);
character.TakeDamage(80);



Console.WriteLine();
Console.WriteLine("7. 표준 이벤트 패턴 (EventArgs)");

Stock stock = new Stock("MSFT", 100);
stock.PriceChanged += (sender, e) =>
{
    Stock stock = (Stock)sender;
    Console.WriteLine($"[{stock}]");
    Console.WriteLine($"  이전 가격: {e.OldPrice:C}");
    Console.WriteLine($"  현재 가격: {e.NewPrice:C}");
    Console.WriteLine($"  변동률: {e.ChangePercent:F2}%");
    Console.WriteLine();
};

stock.ChangePrice(110);
stock.ChangePrice(106);
stock.ChangePrice(120);



Console.WriteLine();
Console.WriteLine("8. 실전 예제 - 연료 경고 시스템");

Car c = new Car(50);

Dashboard dashboard = new Dashboard();
dashboard.Subscribe(c);

Console.OutputEncoding = System.Text.Encoding.UTF8;

for (int i = 0; i < 7; i++)
{
    c.Drive();
    Console.WriteLine();
}



Console.WriteLine();
Console.WriteLine("9. 이벤트 접근자");

void Handler1()
{
    Console.WriteLine("Handler1 실행됨");
}
void Handler2()
{
    Console.WriteLine("Handler1 실행됨");
}

SecurePublisher securePublisher = new SecurePublisher();
securePublisher.Event += Handler1;
securePublisher.Event += Handler2;

Console.WriteLine();
securePublisher.RaiseEvent();

Console.WriteLine();
securePublisher.Event -= Handler1;

Console.WriteLine();
securePublisher.RaiseEvent();



Console.WriteLine();
Console.WriteLine("10. static 이벤트");

Module1 module1 = new Module1();
Module2 module2 = new Module2();

GlobalNotifier.SendMessage("시스템 시작");

Console.WriteLine();
GlobalNotifier.SendMessage("데이터 로드 완료");

delegate void Notify();
delegate void EventHandler();