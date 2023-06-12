<?php
 /**
  * Title: Header Media
  * Slug: outwit-lite/header-media	
  * Categories: outwit-lite, featured
  */
?>
<!-- wp:cover {"url":"<?php echo get_parent_theme_file_uri( '/assets/images/header-media.jpg' ); ?>","id":655,"dimRatio":0,"align":"full","className":"header-media"} -->
<div class="wp-block-cover alignfull header-media">
	<span aria-hidden="true" class="wp-block-cover__background has-background-dim-0 has-background-dim"></span>
	<img class="wp-block-cover__image-background wp-image-655" alt="" src="<?php echo get_parent_theme_file_uri( '/assets/images/header-media.jpg' ); ?>" data-object-fit="cover"/>
	<div class="wp-block-cover__inner-container">
		<!-- wp:group {"layout":{"type":"constrained"}} -->
		<div class="wp-block-group">
			<!-- wp:columns {"verticalAlignment":"center","align":"wide","className":"header-media-content"} -->
			<div class="wp-block-columns alignwide are-vertically-aligned-center header-media-content">
				<!-- wp:column {"verticalAlignment":"center","className":"slider-content","layout":{"type":"default"}} -->
				<div class="wp-block-column is-vertically-aligned-center slider-content">
					<!-- wp:heading {"textAlign":"left","fontSize":"huge"} -->
					<h2 class="has-text-align-left has-huge-font-size"><?php esc_html_e('denim Co.','outwit-lite');?></h2>
					<!-- /wp:heading -->
					<!-- wp:buttons -->
					<div class="wp-block-buttons">
						<!-- wp:button -->
						<div class="wp-block-button">
							<a class="wp-block-button__link wp-element-button"><?php esc_html_e('View More','outwit-lite');?></a>
						</div>
						<!-- /wp:button -->
					</div>
					<!-- /wp:buttons -->
				</div>
				<!-- /wp:column -->
			</div>
			<!-- /wp:columns -->
		</div>
		<!-- /wp:group -->
	</div>
</div>
<!-- /wp:cover -->