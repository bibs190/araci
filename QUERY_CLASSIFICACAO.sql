SELECT USUARIO.nome_usuario, SUM(USUARIO_JOGO.ponto_nivel_jogo)
as 'Quantidade de Pontos' FROM USUARIO  
JOIN USUARIO_JOGO on USUARIO_JOGO.ID_usuario = USUARIO.ID_usuario 
GROUP BY USUARIO.nome_usuario ORDER BY 2 desc 

