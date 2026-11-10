using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_03 : CardInfo
{
    public CardInfo_174_JA_03()
    {
        this.cardNo = "174_JA_03";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ハデス";
        this.cardName2 = "怒髪天の支配者";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
