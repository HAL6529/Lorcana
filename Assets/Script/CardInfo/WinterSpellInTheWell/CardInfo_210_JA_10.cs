using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_210_JA_10 : CardInfo
{
    public CardInfo_210_JA_10()
    {
        this.cardNo = "210_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ホーンド・キング";
        this.cardName2 = "勝ち誇る悪鬼";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DevMadan;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
