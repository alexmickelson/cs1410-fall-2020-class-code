problems you didnt know you had
using solutions you dont know how to comprehend


Building and fixing things


someone who designs and implements something for improvement.


# checkers:

Board Class:
- owns the pieces
- track all the pieces
- 2-dimesional array to represent grid 
  - stores posision of pieces
- piece moving logic
- properly crowns kings


Piece Class:
- track if normal piece or king
- track if on the board or off (dead)
  - delete a piece if not on board
  - possibly track score separately
- track color / affiliation

player object:


Game Class:
- owns 2 players
- owns the board
- track gamestate (in progress, won)
- tracks score
- win conditions
- tracking turns

Screen / IO Class
