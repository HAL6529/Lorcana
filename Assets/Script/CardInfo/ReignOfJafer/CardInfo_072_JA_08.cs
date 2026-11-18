using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_08 : CardInfo
{
    public CardInfo_072_JA_08()
    {
        this.cardNo = "072_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "アナ";
        this.cardName2 = "魔法の密使";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LuigiAime;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
