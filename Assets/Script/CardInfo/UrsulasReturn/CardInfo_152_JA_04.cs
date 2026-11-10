using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_04 : CardInfo
{
    public CardInfo_152_JA_04()
    {
        this.cardNo = "152_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒtƒBƒŠƒbƒv‰¤Žq";
        this.cardName2 = "—EŠ¸‚È–h‰qŽÒ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
