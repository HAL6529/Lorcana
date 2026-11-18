using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_08 : CardInfo
{
    public CardInfo_154_JA_08()
    {
        this.cardNo = "154_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ペリノー卿";
        this.cardName2 = "老練の騎士";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RudyHill;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
