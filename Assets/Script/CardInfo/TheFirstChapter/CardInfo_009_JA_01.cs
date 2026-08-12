using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_01 : CardInfo
{
    public CardInfo_009_JA_01()
    {
        this.cardNo = "009_JA_01";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ÉäÉç";
        this.cardName2 = "Ç®äËÇ¢Ç≤Ç∆";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = "Dave Beauchene";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
