using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_08 : CardInfo
{
    public CardInfo_157_JA_08()
    {
        this.cardNo = "157_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アナ";
        this.cardName2 = "頼る妹";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
