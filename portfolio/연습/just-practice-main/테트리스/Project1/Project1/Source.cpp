#include "Header.h"
#define INTERVAL 1.0 / 60.0

int main()
{
	float prev = (float)clock() / CLOCKS_PER_SEC;
	Display* display = new Display();
	GameEngine* gameEngine = new GameEngine();
	showConsoleCursor(false);

	while (true)
	{
		float curr = (float)clock() / CLOCKS_PER_SEC;
		float dt = curr - prev;

		if (dt < INTERVAL) continue;
		prev = curr;

		bool left = keyState('a');
		if (left)
		{
			
		}
		else
		{

		}

		gameEngine->next(dt, 0);

		gameEngine->makeDisplayData();
		display->draw();

	}
	return 0;
}