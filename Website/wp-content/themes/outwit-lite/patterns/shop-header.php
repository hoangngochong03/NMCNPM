<?php
 /**
  * Title: Shop Header
  * Slug: outwit-lite/shop-header	
  * Categories: outwit-lite, header
  */
?>

<!-- wp:group {"align":"full","className":"no-margin-top banner","layout":{"inherit":true,"type":"constrained"}} -->
	<div class="wp-block-group alignfull no-margin-top banner">
		<!-- wp:group {"align":"full","style":{"spacing":{"padding":{"top":"0px","right":"0px","bottom":"0px","left":"0px"}}},"layout":{"inherit":false}} -->
		<div class="wp-block-group alignfull" style="padding-top:0px;padding-right:0px;padding-bottom:0px;padding-left:0px">
			<!-- wp:cover {"url":"<?php echo get_parent_theme_file_uri( '/assets/images/banner.jpg' ); ?>","id":22620,"dimRatio":50,"gradient":"diagonal-top-to-bottom"} -->
	<div class="wp-block-cover is-dark">
	<span aria-hidden="true" class="wp-block-cover__background has-background-dim wp-block-cover__gradient-background has-background-gradient has-diagonal-top-to-bottom-gradient-background"></span>
		<img class="wp-block-cover__image-background wp-image-22620" alt="banner" src="<?php echo get_parent_theme_file_uri( '/assets/images/banner.jpg' ); ?>" data-object-fit="cover"/>
				<div class="wp-block-cover__inner-container">
					<!-- wp:group {"layout":{"inherit":true,"type":"constrained"}} -->
					<div class="wp-block-group">
							<!-- wp:group {"className":"alignwide"} -->
							<div class="wp-block-group alignwide">
								<!-- wp:heading {"level":1,"className":"has-text-align-center wp-block-post-title"} -->
								<h1 class="has-text-align-center wp-block-post-title"><?php esc_html_e('The Shop','outwit-lite');?></h1>
								<!-- /wp:heading -->
							</div>
							<!-- /wp:group -->
						</div>
						<!-- /wp:group -->
				</div>
			</div>
			<!-- /wp:cover -->
		</div>
		<!-- /wp:group -->
	</div>
<!-- /wp:group -->