using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_06 : CardInfo
{
    public CardInfo_017_JA_06()
    {
        this.cardNo = "017_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "‹â‰Í˜A–M‹c’·";
        this.cardName2 = "˜A–M‚ÌŽw“±ŽÒ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
