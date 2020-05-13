using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternExerciseStub
{
    interface IMediaPlayerState
    {
        void Play(MediaPlayer ctx);
        void Pause(MediaPlayer ctx);
        void Stop(MediaPlayer ctx);
    }
}
