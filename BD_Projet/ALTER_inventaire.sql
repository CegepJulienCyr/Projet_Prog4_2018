USE BD_LEGO_JulienCyr

ALteR TABLE dbo.inventaire 
ADD FOREIGN KEY (set_id) REFERENCES dbo.sets(set_id)

ALTER TABLE dbo.inventaire 
ADD FOREIGN KEY (piece_id) REFERENCES dbo.piece(piece_id)

ALTER TABLE dbo.inventaire 

ADD FOREIGN KEY (user_id) REFERENCES dbo.connexion(id)

