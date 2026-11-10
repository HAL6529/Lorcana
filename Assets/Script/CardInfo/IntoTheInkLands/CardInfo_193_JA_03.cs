using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_03 : CardInfo
{
    public CardInfo_193_JA_03()
    {
        this.cardNo = "193_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒVƒ“ƒo";
        this.cardName2 = "—Bˆê‚Ì‰¤";
        this.power = 4;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
