/* Write your T-SQL query statement below */
SELECT L.book_id ,L.title,L.author,L.genre,L.publication_year,COUNT(B.BOOK_ID) AS current_borrowers         
FROM borrowing_records B JOIN library_books L ON B.BOOK_ID = L.BOOK_ID
WHERE return_date IS NULL
GROUP BY B.BOOK_ID,L.book_id ,L.title,L.author,L.genre,L.publication_year,L.total_copies 
HAVING L.TOTAL_COPIES = COUNT(B.BOOK_ID)
ORDER BY current_borrowers DESC,L.title