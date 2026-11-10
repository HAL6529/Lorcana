using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_03 : CardInfo
{
    public CardInfo_012_JA_03()
    {
        this.cardNo = "012_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉiÉj";
        this.cardName2 = "ê¢òbèƒÇ´Ç®éoÇøÇ·ÇÒ";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ShannonHallstein;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
