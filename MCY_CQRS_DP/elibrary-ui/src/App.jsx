import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import './App.css'

import { useState, useEffect } from 'react'

function App() {
  const [books, setBooks] = useState([])

  useEffect(() => {
    fetch('https://localhost:7045/api/Books')
      .then(res => res.json())
      .then(data => setBooks(data))
  }, [])

  return (
    <div>
      <h1>ELibrary</h1>
      {books.map(book => (
        <div key={book.bookId}>
          <p>{book.bookName}</p>
        </div>
      ))}
    </div>
  )
}

export default App