* {
  margin: 0;
  padding: 0;
}

:root {
  --video-frame-size: 500px;
}

@media (max-width: 400px){
  :root {
    --video-frame-size: 350px;
  }
}

.video {
  width: var(--video-frame-size, 500px;)
  height: var(--video-frame-size, 500px;)
}
