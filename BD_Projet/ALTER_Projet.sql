use BD_LEGO_JulienCyr



alter table set_pieces
ADD PRIMARY KEY (set_id,piece_id,color)
ON DELETE CASCADE

GO
alter table set_pieces
ADD CONSTRAINT Fk_set_id
foreign key (set_id) REFERENCES dbo.sets(set_id)
ON DELETE CASCADE

alter table set_pieces
Add CONSTRAINT fk_colors
FOREIGN KEY (color) REFERENCES dbo.colors(id)
ON DELETE CASCADE


alter table set_pieces
Add CONSTRAINT fk_piecesid
FOREIGN KEY (piece_id) REFERENCES dbo.piece(piece_id)
ON DELETE CASCADE


GO
ALTER TABLE set_pieces
    add UNIQUE (set_id,piece_id,color,type)



