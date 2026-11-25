using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_13 : CardInfo
{
    public CardInfo_022_JA_13()
    {
        this.cardNo = "022_JA_13";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ホーンド・キング";
        this.cardName2 = "無慈悲なる支配者";
        this.power = 5;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
