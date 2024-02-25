import logo from './logo.svg';
import './App.css';
import { useEffect, useState } from 'react';

function App() {
  const [appName, setAppName] = useState<string>();
  const [appTime, setAppTime] = useState<string>();
  
  useEffect(() => {
    setName();
    setTime();
  }, [])

  const setName = () => {
    console.log('Called setName()');
    const name = `Track_MS ${new Date().toLocaleDateString()}`
    setAppName(name);
  }

  const setTime = () => {
    console.log('Called setTime()')
    setAppTime(Date().toString());
  }

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          {appName}
        </a>
        <p>{appTime}</p>
      </header>
    </div>
  );
}

export default App;
