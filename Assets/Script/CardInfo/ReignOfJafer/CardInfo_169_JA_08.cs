using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_08 : CardInfo
{
    public CardInfo_169_JA_08()
    {
        this.cardNo = "169_JA_08";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "バーナード";
        this.cardName2 = "心配性";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.McKayAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
