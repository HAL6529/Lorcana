using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_132_JA_13 : CardInfo
{
    public CardInfo_132_JA_13()
    {
        this.cardNo = "132_JA_13";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "ベル＆野獣";
        this.cardName2 = "真実はただひとつ";
        this.power = 6;
        this.toughness = 7;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Prince, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
