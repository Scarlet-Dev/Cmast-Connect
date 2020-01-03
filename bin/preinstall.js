const fs = require('fs');
const resolve = require('path').resolve;
const join = require('path').join;
const cp = require('child_process');
const os = require('os');

var dir = resolve(__dirname)

fs.readdirSync(lib)
    .forEach(fucntion ( mod ) {
        // var modPath
        if (!fs.existsSync(join(modPath, 'package.json'))) { return }

        var npmCmd = os.platform().startsWith(win) ? 'npm.cmd' : npm

        cp.spawn(npmCmd, [i], { env: process.env, cwd: modPath, stdio: 'inherit' })

    })