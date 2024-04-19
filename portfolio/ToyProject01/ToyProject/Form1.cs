namespace ToyProject
{
    using System;
    using System.Drawing;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Windows.Forms;


    public class Tetris : Form
    {
        private const int Rows = 20; // ���� ������ �� ��
        private const int Columns = 10; // ���� ������ �� ��
        private const int BlockSize = 25; // �� ����� ũ�� (�ȼ�)

        private Panel[,] board; // ���� ���带 ��Ÿ���� �г� 2���� �迭
        private System.Windows.Forms.Timer gameTimer; // ���� Ÿ�̸�
        private Block currentBlock; // ���� �������� ���
        private Random random; // ���� ��� ������ ���� Random ��ü
        private bool gameOver; // ���� ���� ����

        // ��Ʈ���� ������ �ʱ�ȭ�մϴ�.
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

        // ���� ���带 �ʱ�ȭ�մϴ�.
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

        // ���� Ÿ�̸Ӹ� �ʱ�ȭ�մϴ�.
        private void InitializeGameTimer()
        {
            gameTimer = new System.Windows.Forms.Timer
            {
                Interval = 500 // ����� �������� ���� (�и���)
            };
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        // ���� Ÿ�̸� ƽ �̺�Ʈ �ڵ鷯
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (gameOver)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over");
                return;
            }

            // ���� ����� �Ʒ��� �̵�
            if (!MoveBlockDown())
            {
                // ���� ����� ������ �� ���� ���
                AddBlockToBoard();
                ClearFullRows();
                SpawnNewBlock();

                if (IsGameOver())
                {
                    gameOver = true;
                }
            }
        }

        // ���ο� ����� �����Ͽ� ���� ���忡 �߰��մϴ�.
        private void SpawnNewBlock()
        {
            currentBlock = Block.CreateRandomBlock(random, Columns / 2, 0);

            if (!IsValidBlockPosition(currentBlock))
            {
                // ���� ����
                gameOver = true;
            }
        }

        // ���� ����� ���� ���忡 �߰��մϴ�.
        private void AddBlockToBoard()
        {
            foreach (Point cell in currentBlock.Cells)
            {
                int row = currentBlock.Position.Y + cell.Y;
                int col = currentBlock.Position.X + cell.X;
                board[row, col].BackColor = currentBlock.Color;
            }
        }

        // ���� ����� �Ʒ��� �̵��մϴ�.
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

        // ���� ���忡�� ������ ���� �����մϴ�.
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
                    // ������ ���� �����ϰ�, ������ �Ʒ��� �����ϴ�.
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

        // ���� ����� ��ġ�� ��ȿ���� Ȯ���մϴ�.
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

        // ���� ���� ���θ� Ȯ���մϴ�.
        private bool IsGameOver()
        {
            // ���� ����� ������ ��ġ�� �̹� ����� ���� ��� ���� ����
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

        // ���� ����� �������� �̵��մϴ�.
        private void MoveBlockLeft()
        {
            Block newBlock = currentBlock.Clone();
            newBlock.Position.X--;

            if (IsValidBlockPosition(newBlock))
            {
                currentBlock = newBlock;
            }
        }

        // ���� ����� ���������� �̵��մϴ�.
        private void MoveBlockRight()
        {
            Block newBlock = currentBlock.Clone();
            newBlock.Position.X++;

            if (IsValidBlockPosition(newBlock))
            {
                currentBlock = newBlock;
            }
        }

        // ���� ����� ȸ���մϴ�.
        private void RotateBlock()
        {
            Block newBlock = currentBlock.Clone();
            newBlock.Rotate();

            if (IsValidBlockPosition(newBlock))
            {
                currentBlock = newBlock;
            }
        }

        // Ű���� �Է� ó��
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

        // ������ �����մϴ�.
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

        // ����� �����մϴ�.
        public Block(Point[] cells, Color color)
        {
            Cells = cells;
            Color = color;
            Position = new Point(0, 0);
        }

        // ����� ȸ���մϴ�.
        public void Rotate()
        {
            for (int i = 0; i < Cells.Length; i++)
            {
                Point cell = Cells[i];
                Cells[i] = new Point(-cell.Y, cell.X);
            }
        }

        // ����� �����մϴ�.
        // ����� �����մϴ�.
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

        // ���� ����� �����մϴ�.
        public static Block CreateRandomBlock(Random random, int startX, int startY)
        {
            Point[] cells;
            Color color;

            switch (random.Next(7))
            {
                case 0:
                    // I ���
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(0, 3) };
                    color = Color.Cyan;
                    break;
                case 1:
                    // O ���
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0), new Point(1, 1) };
                    color = Color.Yellow;
                    break;
                case 2:
                    // T ���
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 1) };
                    color = Color.Purple;
                    break;
                case 3:
                    // L ���
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 0) };
                    color = Color.Orange;
                    break;
                case 4:
                    // J ���
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 2) };
                    color = Color.Blue;
                    break;
                case 5:
                    // S ���
                    cells = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 2) };
                    color = Color.Green;
                    break;
                case 6:
                    // Z ���
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
