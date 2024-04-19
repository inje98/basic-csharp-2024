namespace ToyProject
{
    using System;
    using System.Drawing;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Windows.Forms;


    public class Tetris : Form
    {
        private const int Rows = 20; // 게임 보드의 행 수
        private const int Columns = 10; // 게임 보드의 열 수
        private const int BlockSize = 25; // 각 블록의 크기 (픽셀)

        private Panel[,] board; // 게임 보드를 나타내는 패널 2차원 배열
        private System.Windows.Forms.Timer gameTimer; // 게임 타이머
        private Block currentBlock; // 현재 떨어지는 블록
        private Random random; // 랜덤 블록 생성을 위한 Random 객체
        private bool gameOver; // 게임 오버 여부

        // 테트리스 게임을 초기화합니다.
        public Tetris()
        {
            Text = "Tetris";
            Size = new Size(Columns * BlockSize + 200, Rows * BlockSize + 50);
            board = new Panel[Rows, Columns];
            random = new Random();
            gameOver = false;

            InitializeBoard();
            InitializeGameTimer();
            SpawnNewBlock();
        }

        // 게임 보드를 초기화합니다.
        private void InitializeBoard()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    Panel panel = new Panel
                    {
                        Size = new Size(BlockSize, BlockSize),
                        Location = new Point(col * BlockSize, row * BlockSize),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White
                    };
                    Controls.Add(panel);
                    board[row, col] = panel;
                }
            }
        }

        // 게임 타이머를 초기화합니다.
        private void InitializeGameTimer()
        {
            gameTimer = new System.Windows.Forms.Timer
            {
                Interval = 500 // 블록이 떨어지는 간격 (밀리초)
            };
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        // 게임 타이머 틱 이벤트 핸들러
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (gameOver)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over");
                return;
            }

            // 현재 블록을 아래로 이동
            if (!MoveBlockDown())
            {
                // 현재 블록을 움직일 수 없는 경우
                AddBlockToBoard();
                ClearFullRows();
                SpawnNewBlock();

                if (IsGameOver())
                {
                    gameOver = true;
                }
            }
        }

        // 새로운 블록을 생성하여 게임 보드에 추가합니다.
        private void SpawnNewBlock()
        {
            currentBlock = Block.CreateRandomBlock(random, Columns / 2, 0);

            if (!IsValidBlockPosition(currentBlock))
            {
                // 게임 오버
                gameOver = true;
            }
        }

        // 현재 블록을 게임 보드에 추가합니다.
        private void AddBlockToBoard()
        {
            foreach (Point cell in currentBlock.Cells)
            {
                int row = currentBlock.Position.Y + cell.Y;
                int col = currentBlock.Position.X + cell.X;
                board[row, col].BackColor = currentBlock.Color;
            }
        }

        // 현재 블록을 아래로 이동합니다.
        private bool MoveBlockDown()
        {
            Block newBlock = currentBlock.Clone();
            newBlock.Position.Y++;

            if (IsValidBlockPosition(newBlock))
            {
                currentBlock = newBlock;
                return true;
            }

            return false;
        }

        // 게임 보드에서 완전한 줄을 제거합니다.
        private void ClearFullRows()
        {
            for (int row = 0; row < Rows; row++)
            {
                bool fullRow = true;

                for (int col = 0; col < Columns; col++)
                {
                    if (board[row, col].BackColor == Color.White)
                    {
                        fullRow = false;
                        break;
                    }
                }

                if (fullRow)
                {
                    // 완전한 줄을 제거하고, 윗줄을 아래로 내립니다.
                    for (int r = row; r > 0; r--)
                    {
                        for (int col = 0; col < Columns; col++)
                        {
                            board[r, col].BackColor = board[r - 1, col].BackColor;
                        }
                    }

                    for (int col = 0; col < Columns; col++)
                    {
                        board[0, col].BackColor = Color.White;
                    }
                }
            }
        }

        // 현재 블록의 위치가 유효한지 확인합니다.
        private bool IsValidBlockPosition(Block block)
        {
            foreach (Point cell in block.Cells)
            {
                int row = block.Position.Y + cell.Y;
                int col = block.Position.X + cell.X;

                if (row < 0 || row >= Rows || col < 0 || col >= Columns ||
                    board[row, col].BackColor != Color.White)
                {
                    return false;
                }
            }

            return true;
        }

        // 게임 오버 여부를 확인합니다.
        private bool IsGameOver()
        {
            // 현재 블록이 생성될 위치에 이미 블록이 있을 경우 게임 오버
            foreach (Point cell in currentBlock.Cells)
            {
                int row = currentBlock.Position.Y + cell.Y;
                int col = currentBlock.Position.X + cell.X;

                if (board[row, col].BackColor != Color.White)
                {
                    return true;
                }
            }

            return false;
        }

        // 현재 블록을 왼쪽으로 이동합니다.
        private void MoveBlockLeft()
        {
            Block newBlock = currentBlock.Clone();
            newBlock.Position.X--;

            if (IsValidBlockPosition(newBlock))
            {
                currentBlock = newBlock;
            }
        }

        // 현재 블록을 오른쪽으로 이동합니다.
        private void MoveBlockRight()
        {
            Block newBlock = currentBlock.Clone();
            newBlock.Position.X++;

            if (IsValidBlockPosition(newBlock))
            {
                currentBlock = newBlock;
            }
        }

        // 현재 블록을 회전합니다.
        private void RotateBlock()
        {
            Block newBlock = currentBlock.Clone();
            newBlock.Rotate();

            if (IsValidBlockPosition(newBlock))
            {
                currentBlock = newBlock;
            }
        }

        // 키보드 입력 처리
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    MoveBlockLeft();
                    break;
                case Keys.Right:
                    MoveBlockRight();
                    break;
                case Keys.Up:
                    RotateBlock();
                    break;
                case Keys.Down:
                    MoveBlockDown();
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            return true;
        }

        // 게임을 시작합니다.
        public static void Main()
        {
            Application.Run(new Tetris());
        }
    }

    public class Block
    {
        public Point Position { get; set; }
        public Point[] Cells { get; set; }
        public Color Color { get; set; }

        // 블록을 생성합니다.
        public Block(Point[] cells, Color color)
        {
            Cells = cells;
            Color = color;
            Position = new Point(0, 0);
        }

        // 블록을 회전합니다.
        public void Rotate()
        {
            for (int i = 0; i < Cells.Length; i++)
            {
                Point cell = Cells[i];
                Cells[i] = new Point(-cell.Y, cell.X);
            }
        }

        // 블록을 복제합니다.
        // 블록을 복제합니다.
        public Block Clone()
        {
            Point[] clonedCells = new Point[Cells.Length];
            Cells.CopyTo(clonedCells, 0);
            Block newBlock = new Block(clonedCells, Color)
            {
                Position = new Point(Position.X, Position.Y)
            };
            return newBlock;
        }

        // 랜덤 블록을 생성합니다.
        public static Block CreateRandomBlock(Random random, int startX, int startY)
        {
            Point[] cells;
            Color color;

            switch (random.Next(7))
            {
                case 0:
                    // I 블록
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(0, 3) };
                    color = Color.Cyan;
                    break;
                case 1:
                    // O 블록
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0), new Point(1, 1) };
                    color = Color.Yellow;
                    break;
                case 2:
                    // T 블록
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 1) };
                    color = Color.Purple;
                    break;
                case 3:
                    // L 블록
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 0) };
                    color = Color.Orange;
                    break;
                case 4:
                    // J 블록
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 2) };
                    color = Color.Blue;
                    break;
                case 5:
                    // S 블록
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 2) };
                    color = Color.Green;
                    break;
                case 6:
                    // Z 블록
                    cells = new Point[] { new Point(0, 1), new Point(0, 2), new Point(1, 0), new Point(1, 1) };
                    color = Color.Red;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected block type.");
            }

            Block block = new Block(cells, color)
            {
                Position = new Point(startX, startY)
            };

            return block;
        }
    }
}
