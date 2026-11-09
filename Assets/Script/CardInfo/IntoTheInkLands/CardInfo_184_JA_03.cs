using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_03 : CardInfo
{
    public CardInfo_184_JA_03()
    {
        this.cardNo = "184_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミスター・スミー";
        this.cardName2 = "マヌケなお仲間";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlibethZermeno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
