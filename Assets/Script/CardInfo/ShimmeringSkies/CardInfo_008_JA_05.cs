using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_05 : CardInfo
{
    public CardInfo_008_JA_05()
    {
        this.cardNo = "008_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉäÉç";
        this.cardName2 = "ÉPÅ[ÉLè¸ÇËåWÇÃå©èKÇ¢";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OliverDesiree;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
