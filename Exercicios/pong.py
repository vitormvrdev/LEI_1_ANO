import pygame
import sys
import random

# Inicializar o Pygame
pygame.init()

# Constantes
LARGURA, ALTURA = 600, 400
BRANCO = (255, 255, 255)
RAIO_BOLA = 15
LARGURA_PADDLE, ALTURA_PADDLE = 10, 60
FPS = 60

# Criar a janela do jogo
janela = pygame.display.set_mode((LARGURA, ALTURA))
pygame.display.set_caption("Jogo de Pong")

# Relógio para controlar a taxa de quadros por segundo
relogio = pygame.time.Clock()

# Posições iniciais
bola_x = LARGURA // 2
bola_y = ALTURA // 2
velocidade_bola_x = random.choice([3, -3])
velocidade_bola_y = random.choice([2, -2])

paddle_a_y = (ALTURA - ALTURA_PADDLE) // 2
paddle_b_y = (ALTURA - ALTURA_PADDLE) // 2

# Classe Scoreboard
class Scoreboard:
    def __init__(self):
        self.pontos_a = 0
        self.pontos_b = 0
        self.fonte = pygame.font.Font(None, 36)

    def mostrar_pontos(self):
        texto_pontos = self.fonte.render(f"{self.pontos_a} - {self.pontos_b}", True, BRANCO)
        janela.blit(texto_pontos, ((LARGURA - texto_pontos.get_width()) // 2, 10))

# Criar um placar
placar = Scoreboard()

# Laço principal do jogo
while True:
    for evento in pygame.event.get():
        if evento.type == pygame.QUIT:
            pygame.quit()
            sys.exit()

    teclas = pygame.key.get_pressed()
    if teclas[pygame.K_w] and paddle_a_y > 0:
        paddle_a_y -= 5
    if teclas[pygame.K_s] and paddle_a_y < ALTURA - ALTURA_PADDLE:
        paddle_a_y += 5

    teclas = pygame.key.get_pressed()
    if teclas[pygame.K_UP] and paddle_b_y > 0:
        paddle_b_y -= 5
    if teclas[pygame.K_DOWN] and paddle_b_y < ALTURA - ALTURA_PADDLE:
        paddle_b_y += 5

    # Movimento da bola
    bola_x += velocidade_bola_x * 2
    bola_y += velocidade_bola_y * 2

    # Colisões da bola
    if bola_y <= 0 or bola_y >= ALTURA - RAIO_BOLA:
        velocidade_bola_y = -velocidade_bola_y

    # Colisões da bola com as raquetes
    if (
        paddle_a_y < bola_y < paddle_a_y + ALTURA_PADDLE
        and bola_x <= LARGURA_PADDLE
    ) or (
        paddle_b_y < bola_y < paddle_b_y + ALTURA_PADDLE
        and bola_x >= LARGURA - LARGURA_PADDLE - RAIO_BOLA
    ):
        velocidade_bola_x = -velocidade_bola_x

    # Bola fora dos limites
    if bola_x < 0 or bola_x > LARGURA:
        bola_x = LARGURA // 2
        bola_y = ALTURA // 2
        velocidade_bola_x = random.choice([3, -3])
        velocidade_bola_y = random.choice([2, -2])

        # Atualizar os pontos do placar
        if bola_x < 0:
            placar.pontos_b += 1
        else:
            placar.pontos_a += 1

    # Desenhar os elementos
    janela.fill((0, 0, 0))
    pygame.draw.rect(janela, BRANCO, (LARGURA_PADDLE, paddle_a_y, LARGURA_PADDLE, ALTURA_PADDLE))
    pygame.draw.rect(
        janela,
        BRANCO,
        (LARGURA - LARGURA_PADDLE * 2, paddle_b_y, LARGURA_PADDLE, ALTURA_PADDLE),
    )
    pygame.draw.circle(janela, BRANCO, (bola_x, bola_y), RAIO_BOLA)

    # Atualizar o placar
    placar.mostrar_pontos()

    # Atualizar a tela
    pygame.display.flip()

    # Limitar a taxa de quadros por segundo
    relogio.tick(FPS)
