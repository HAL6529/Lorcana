using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_08 : CardInfo
{
    public CardInfo_199_JA_08()
    {
        this.cardNo = "199_JA_08";
        this.inkCost = 10;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "でっかいマウス";
        this.power = 10;
        this.toughness = 10;
        this.lore = 5;
        this.illustrator = EnumController.Illustrator.JoyAngAndGiuliaRiva;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
