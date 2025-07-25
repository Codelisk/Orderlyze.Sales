# GitHub Actions Documentation

## Claude Code Review Action

This workflow automatically reviews pull requests using Claude Code CLI on a self-hosted runner.

### Setup Instructions

1. **Set up a Self-hosted GitHub Runner:**
   - Go to: https://github.com/Orderlyze/Orderlyze.Sales/settings/actions/runners
   - Click "New self-hosted runner"
   - Follow the setup instructions for your OS
   - Install the runner on a machine where Claude Code CLI is available

2. **Install Claude Code CLI on the Runner:**
   - Install Claude Code CLI on the self-hosted runner machine
   - Log in with your Claude subscription
   - Ensure `claude --version` works in the terminal

3. **How it works:**
   - **Automatic triggers**: PR creation or updates
   - **Manual triggers**: Comments with `@claude` or `/claude` in PRs or issues
   - Runs on your self-hosted runner (not GitHub's servers)
   - Uses your locally installed Claude Code CLI with subscription
   - Extracts the PR diff and changed files
   - Posts the review as a comment

4. **Benefits:**
   - ✅ Uses your Claude subscription (no API costs)
   - ✅ Runs on your own infrastructure
   - ✅ No API keys needed in GitHub secrets
   - ✅ Full access to Claude Code CLI features

5. **Requirements:**
   - Self-hosted GitHub runner configured
   - Claude Code CLI installed and authenticated on runner
   - Runner must have internet access for GitHub API calls

### Manual Triggers

You can manually trigger a Claude code review by commenting on any PR or issue with:

- `@claude` - Triggers a code review
- `/claude` - Alternative trigger command

#### Auto-Fix Mode (NEW!)

Add `--fix`, `and fix`, or `auto-fix` to your comment to enable automatic code fixes:

- `@claude review this --fix` - Review and automatically fix issues
- `/claude please check and fix this code`
- `@claude auto-fix the security issues`

**Auto-fix mode will:**
- ✅ Analyze the code and provide a review
- ✅ Automatically fix detected issues using available tools
- ✅ Commit changes to the PR branch
- ✅ Provide a follow-up review of the fixes

Examples:
- `@claude please review this PR`
- `/claude can you check the security aspects?`
- `@claude review and fix this --fix`
- `Hey @claude, auto-fix any issues you find`

### Customization

To change the review focus, edit the prompt in the "Review with Claude Code" step in `.github/workflows/claude-code-review.yml`.

### Setting up Self-hosted Runner

1. **Install GitHub Runner:**
   ```bash
   # Download and configure GitHub Actions runner
   # Follow instructions from GitHub repository settings
   ```

2. **Install Claude Code CLI:**
   ```bash
   # Install Claude Code CLI on the runner machine
   npm install -g @anthropic-ai/claude-code
   # Or follow official installation guide
   ```

3. **Authenticate Claude Code:**
   ```bash
   # Log in with your subscription
   claude auth login
   ```