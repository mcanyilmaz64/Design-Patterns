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


  const handleDelete = async (id) => {
    await fetch(`https://localhost:7045/api/Books/${id}`, {
      method: 'DELETE'
    })
    setBooks(books.filter(book => book.bookId !== id))
  }

  const handleUpdate = async (id) => {
    await fetch(`https://localhost:7045/api/Books/${id}`, {
      method: 'PUT'
    })
    setBooks(books.filter(book => book.bookId !== id))
  }



  return (
    <div className='container'>
      <br />
      <table className='table table-striped'>
        <thead className='table-dark'>
          <tr>
            <th> Book Name </th>
            <th> Url </th>
            <th> Price </th>
            <th> Category </th>
            <th> Delete </th>
            <th> Update </th>
          </tr>
        </thead>

        <tbody>
          {books.map(book => (
            <tr key={book.id}>
              <td>{book.bookName}</td>
              <td>{book.url}</td>
              <td>{book.price}</td>
              <td>{book.categoryId}</td>
              <td>
                <button className='btn btn-danger' onClick={() => handleDelete(book.bookId)}>Delete</button>
              </td>
              <td>
                <button className='btn btn-primary' onClick={() => handleUpdate(book.bookId)}>Update</button>
              </td>
            </tr>
          ))}
        </tbody>

      </table>
      <button className='btn btn-warning'>Add Book</button>

    </div>
  )
}

export default App
